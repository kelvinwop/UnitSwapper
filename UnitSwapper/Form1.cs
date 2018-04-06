using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitSwapper
{
    public enum BaseType { ElectricalCurrent, Luminosity, Temperature, Mass, Length, Amount, Time };

    public partial class Form1 : Form
    {
        public Dictionary<string, BaseType> UnitType = new Dictionary<string, BaseType>()
        {
            {"kg", BaseType.Mass},
            {"slug", BaseType.Mass},
            {"g", BaseType.Mass},
            {"mg", BaseType.Mass},
            {"lbm", BaseType.Mass}, //pound_mass
            {"m", BaseType.Length},
            {"cm", BaseType.Length},
            {"mm", BaseType.Length},
            {"km", BaseType.Length},
            {"in", BaseType.Length},
            {"mi", BaseType.Length},
            {"yd", BaseType.Length},
            {"ft", BaseType.Length},
            {"a", BaseType.ElectricalCurrent}, //ampere
            {"day", BaseType.Time},
            {"h", BaseType.Time},
            {"min", BaseType.Time},
            {"s", BaseType.Time},
            {"ms", BaseType.Time},
            {"week", BaseType.Time},
            {"month", BaseType.Time},
            {"k", BaseType.Temperature},
            {"c", BaseType.Temperature},
            {"f", BaseType.Temperature},
            {"r", BaseType.Temperature},
            {"cd", BaseType.Luminosity}, //candela
            {"mol", BaseType.Amount} //mole
        };

        public Dictionary<string, double> ConversionRatios = new Dictionary<string, double>()
        {
            {"kg", 1000},
            {"slug", 14593.9},
            {"g", 1},
            {"mg", 0.001},
            {"lbm", 453.592}, //pound_mass
            {"m", 1},
            {"cm", 0.01},
            {"mm", 0.001},
            {"km", 1000},
            {"in", 0.0254},
            {"mi", 1609.34},
            {"yd", 0.9144},
            {"ft", 0.3048},
            {"a", 1}, //ampere
            {"day", 86400},
            {"h", 3600},
            {"min", 60},
            {"s", 1},
            {"ms", 0.001},
            {"week", 604800},
            {"month", 2.628e6},
            {"k", 1},
            {"c", 1},
            {"f", 1.8},
            {"r", 1.8},
            {"cd", 1}, //candela
            {"mol", 1}, //mole
        };

        float inputAmount;
        string inputUnits;
        string outputUnits;
        List<Unit> inputUnitList;
        List<Unit> outputUnitList;
        int[] inputProfile;
        int[] outputProfile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                inputAmount = Int32.Parse(txt_InputValue.Text);
            }
            catch
            {
                MessageBox.Show("Amount box value invalid (Could not parse to floating point)", "Error!");
                return;
            }
            inputUnits = txt_InputUnits.Text;
            outputUnits = txt_OutputUnits.Text;

            //read text into unit lists
            inputUnitList = readUnits(inputUnits);
            outputUnitList = readUnits(outputUnits);

            //make sure same number of each units in input and output
            inputProfile = profileUnits(inputUnitList);
            outputProfile = profileUnits(outputUnitList);

            if(!Enumerable.SequenceEqual(inputProfile,outputProfile))
            {
                MessageBox.Show("Quantity of each unit type does not match. Please check input and output.", "Error");
                return;
            }

            //convert and evangelize the metric
            double scalarIN = 1;
            string log = "";
            foreach(Unit u in inputUnitList)
            {
                double value;
                ConversionRatios.TryGetValue(u.name, out value);
                scalarIN *= Math.Pow(value,u.number);
                log += u.name + "||";
            }
            double scalarOUT = 1;
            foreach (Unit u in outputUnitList)
            {
                double value;
                ConversionRatios.TryGetValue(u.name, out value);
                scalarOUT *= Math.Pow(value, u.number);
            }

            txt_OutputValue.Text = "" + scalarIN / scalarOUT * inputAmount;
        }

        int[] profileUnits(List<Unit> list)
        {
            int[] output = new int[7];
            foreach(Unit u in list)
            {
                if (u.number > 0)
                    output[(int)u.type]++;
                else
                    output[(int)u.type]--;
            }
            return output;
        }

        List<Unit> readUnits(string list)
        {
            List<Unit> output = new List<Unit>();
            foreach(string s in list.Split(' '))
            {
                BaseType value;
                if(UnitType.TryGetValue(s.Split('^')[0], out value))
                {
                    if (s.Contains("^"))
                    {
                        output.Add(new Unit(s.Split('^')[0], value, Int32.Parse(s.Split('^')[1])));
                    }
                    else
                    {
                        output.Add(new Unit(s, value));
                    }
                }
                else
                {
                    MessageBox.Show("Could not identify " + s, "Error");
                    return new List<Unit>();
                }
            }

            //remove duplicates
            var duplicateUnits = output.GroupBy(x => x).Where(group => group.Count() > 1).Select(group => group.Key);

            foreach(var d in duplicateUnits)
            {
                int count = 0;
                foreach (Unit u in output)
                {
                    if(u.Equals(d))
                    {
                        count += u.number;
                    }
                }
                output.RemoveAll(x => x.Equals(d));
                if(count != 0)
                {
                    output.Add(new Unit(d.name, d.type, count));
                }
            }
            return output;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_OutputValue.Text = "";
            txt_OutputUnits.Text = "";
            txt_InputValue.Text = "";
            txt_InputUnits.Text = "";
        }
    }

    public class Unit
    {
        public string name; //eg. km, s, mi, etc...
        public BaseType type;
        public int number;
        public Unit(string name, BaseType type)
        {
            this.name = name;
            this.type = type;
            this.number = 1;
        }
        public Unit(string name, BaseType type, int number)
        {
            this.name = name;
            this.type = type;
            this.number = number;
        }
        public override bool Equals(object obj)
        {
            Unit obj2 = (Unit)obj;
            return (obj2.name == this.name && obj2.type == this.type);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

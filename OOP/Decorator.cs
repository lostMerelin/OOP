using System.Globalization;


namespace OOP
{ 
    public abstract class Data
    {
        public string Name { get; private set; }

        public Data(string name)
        {
            this.Name = name;
        }
        public abstract string GetData();
    }
    public interface IData
    {
        string Culture { get; }
    }
    public class EuropData : Data, IData
    {
        public string Culture { get; protected set; }

        public EuropData() : base("Europ")
        {
            Culture = "Sp";
        }
        public override string GetData()
        {
            DateTime now = DateTime.Now;
            CultureInfo cultureInfo = new CultureInfo(Culture);
            return now.ToString("dd/MM/yyyy HH:mm:ss", cultureInfo);
        }
    }
    public class UsaData : Data, IData
    {
        public string Culture { get; protected set; }
        public UsaData() : base("Usa")
        {
            Culture = "en-US";
        }
        public override string GetData()
        {
            DateTime now = DateTime.Now;
            CultureInfo cultureInfo = new CultureInfo(Culture);
            return now.ToString("MM/dd/yyyy hh:mm:ss tt", cultureInfo);
        }
    }

    public abstract class DataDecorator : Data
    {
        protected Data Data;
        public DataDecorator(string name, Data data) : base(name)
        {
            Data = data;
        }
    }
    public class EuropDecorator : DataDecorator
    {
        public EuropDecorator(Data data) : base($"{data.Name} c символами", data)
        {

        }
        public override string GetData()
        {
            return Data.GetData() + " aaa";
        }
    }
    public class UsaDecorator : DataDecorator
    {
        public UsaDecorator(Data data) : base($"{data.Name} c символами", data)
        {

        }
        public override string GetData()
        {
            return Data.GetData() + " aaa";
        }
    }
}

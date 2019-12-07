namespace Activity4
{
    public abstract class Currency
    {
        public double Value { get; set; }
        
        public string Name { get; }

        protected Currency(double value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}
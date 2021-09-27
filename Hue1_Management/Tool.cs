namespace Hue1_Management
{
    public class Tool : Ware
    {
        private double Weight { get; set; }

        public Tool(int id, double weight) : base(id)
        {
            this.Weight = weight;
        }

        public override string Desc()
        {
            return $"#{base.ID}: Tool {Weight:0.0}kg";
        }

        public override string Shortcut()
        {
            return "T";
        }
        
    }
}
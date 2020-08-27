namespace Washing_Machine
{
    class WashPrograms
    {
        private string[] programs =
        {
            //Variables for the Time, the Amount of water its using and the Warmness of the water, in order as follows Name, Time, Water, warmness
            "Basic wash, 60, 50L, 40", // Basic Wash
            "Eco Wash, 50, 38L, 40", // Eco Wash
            "Quick Wash, 30, 35L, 40", // Quick Wash
            "Heavy Wash, 90, 64L, 45" // Heavy Wash
        };

        public string[] Programs { get { return programs; } }
    }
}

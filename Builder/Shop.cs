namespace Builder
{
    internal class Shop
    {
        /// <summary>
        /// The 'Director' class
        /// </summary>
        /// <param name="vehicleBuilder"></param>
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
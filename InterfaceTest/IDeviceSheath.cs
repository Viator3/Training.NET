namespace InterfaceTest
{
    interface IDeviceSheath
    {
        int ScreenSize { get; }
        string Name { get; set; }
        string Control { get; set; }
        string Speaker { get; set; }
    }

    interface IInternalFunctions
    {
        void EnteringInformation();
        void InformationOutput();
    }
}

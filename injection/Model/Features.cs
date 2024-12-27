namespace injection.Model
{
    /// model should match config.json
    public class Features
    {
        public string Env { get; set; } 
        public External? External { get; set; }
    }

    public class External
    {
        public string? Color { get; set; }
    }
}

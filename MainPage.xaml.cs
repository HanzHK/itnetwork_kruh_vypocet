namespace kruh_vypocet
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            JednotkyPicker.ItemsSource = Jednotky;
        }

        public static List<string> Jednotky { get; } = new List<string> { "m", "cm", "mm" };


        private void VypocitejBtnClicked(object sender, EventArgs e)
        {
            string polomerVstup = PolomerEntry.Text;
            double obvod = Vypocty.VypisObvod(polomerVstup);
            double obsah = Vypocty.VypisObsah(polomerVstup);
            VysledekObvodLabel.Text = $"Obvod: {obvod}";
            VysledekObsahLabel.Text = $"Obsah: {obsah}";
        }
    }
    internal static class Vypocty
    {
        public static double VypisObvod(string polomerText)
        {
            if (double.TryParse(polomerText, out double polomer))
            {
                return VypocitejObvod(polomer);


            }
            else
            {
                return 0; 
            }
        }
        public static double VypisObsah(string polomerText)
        {
            if (double.TryParse(polomerText, out double polomer))
            {
                return VypocitejObsah(polomer);


            }
            else
            {
                return 0;
            }
        }
        private static double VypocitejObvod(double polomer)
        {
            return 2 * Math.PI * polomer;
        }
        private static double VypocitejObsah(double polomer)
        {
            return Math.PI * polomer * polomer;
        }
    }
}

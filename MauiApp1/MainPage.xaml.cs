namespace MauiApp1 {
    public partial class MainPage : ContentPage {
        int count = 0;

        public MainPage() {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e) {
            count = ClassLibrary1.Class1.AddARandomNumber(count);
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
namespace GestionEtudiant
{
    internal class ComboBoxItem
    {
        private string value;
        private string text;

        public ComboBoxItem(string Value, string Text)
        {
            this.text = Text;
            this.Value = Value;
        }

        public string Value { get => value; set => this.value = value; }

        public override string ToString()
        {
            return text;
        }
    }
}
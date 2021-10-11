namespace SpecificationParameters.Model
{
    public abstract class SpecificationParams
    {
        private string _search;

        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }
    }
}
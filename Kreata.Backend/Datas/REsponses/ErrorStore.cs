namespace Kreta.Backend.Datas.REsponses
{
    public class ErrorStore
    {
        public ErrorStore()
        {
            Error = string.Empty;

        }

        public string Error { get; set; } = string.Empty;

        public bool HasError => !string.IsNullOrEmpty(Error);

        public void Clear()
        {
            Error = string.Empty;
        }

        public void ClearAddError(string error)
        {
            Error = error;
        }

        public void AddNewError(string error)
        {
            Error = $"{Error}\n{error}";
        }
    }
}
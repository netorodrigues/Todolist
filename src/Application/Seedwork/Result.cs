namespace Application.Seedwork
{
    public class Result
    {
        public int Code { get; set; }
        public string Content { get; set; }
        public Result(int code, string content)
        {
            Code = code;
            Content = content;
        }

    }
}

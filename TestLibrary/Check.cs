namespace TestLibrary
{


    public class Annotator : IImageAnnotator
    {
        public Annotator()
        {
            Width = "width";
            Ratio = 2;
        }
        public string Width { get; }
        public int Ratio { get; }
    }

    public class PDTAnnotator : IImageAnnotator, IImageAnnotatorExtended
    {
        public PDTAnnotator()
        {
            
        }
        public int Priority { get; }
        public string Width { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IImageAnnotator
    {
        /// <summary>
        /// 
        /// </summary>
        string Width { get; }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IImageAnnotatorExtended
    {
        /// <summary>
        /// 
        /// </summary>
        int Priority { get; }
    }
}
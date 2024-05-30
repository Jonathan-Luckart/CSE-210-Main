public class Video
{
    private String _title;
    private String _author;
    private Double _length;
    private List<Comment> _comments;

    //-----------------------------------

    public Video(String title, String author, Double length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    //------------------------------------------

    public int CommentAmount()
    {
        int amount = _comments.Count;
        return amount;
    }

    public String GetTitle()
    {
        return _title;
    }

    public String GetAuthor()
    {
        return _author;
    }

    public Double Getlength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}
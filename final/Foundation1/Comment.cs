public class Comment
{
    private String _commenter;
    private String _commentText;

    //---------------------------

    public Comment(String commenter, String commentText)
    {
        _commenter = commenter;
        _commentText = commentText;
    }

    //--------------------------------

    public String GetCommenter()
    {
        return _commenter;
    }

    public String GetText()
    {
        return _commentText;
    }
}
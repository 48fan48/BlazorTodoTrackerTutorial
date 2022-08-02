public class TodoObj
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;

    public bool IsRemoved { get; set; } = false;

    public int Minutes { get; set; }

    public string? Description { get; set; }


    public bool getIsDone()
    {
        return IsDone;
    }



    public string getColor()
    {

        if (this.IsDone)
        {
            return "LimeGreen";
        }

        if (!this.IsDone)
        {
            return "Red";
        }

        else
        {
            return "purple";
        }

    }
}
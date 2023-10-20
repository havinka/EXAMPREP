
public class OnSiteJobOffer : JobOffer
{
    private string city;

    public string City
    {
        get { return this.city; }
        set
        {
            if (value.Length < 3 || value.Length>30)
            {
                throw new ArgumentException("Error");
            }
            city = value;
        }
    }
    public OnSiteJobOffer(string jobTitle, string company, double salary,string city) : base(jobTitle, company, salary)
    {
        City = city;
    }

    public override string ToString()
    {
        return base.ToString() +$"{Environment.NewLine}City: {City}";
    }
}



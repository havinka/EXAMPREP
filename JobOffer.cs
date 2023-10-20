using System.Text;
public abstract class JobOffer
{
    private string jobTitle;

    private string company;

    private double salary;

    protected JobOffer(string jobTitle, string company, double salary)
    {
        this.jobTitle = jobTitle;
        this.company = company;
        this.salary = salary;
    }

    public string JobTitle
    {
        get
        {
            return this.jobTitle;
        }
        private set
        {
            if (value.Length < 3 || value.Length>30)
            {
                throw new ArgumentException("JobTitle should be between 3 and 30 characters!");
            }

            this.jobTitle = value;
        }
    }

    public string Company
    {
        get
        {
            return this.company;
        }
        private set
        {
            if (value.Length < 3 || value.Length>30)
            {
                throw new ArgumentException("Company should be between 3 and 30 characters! ");
            }
            this.company = value;
        }
    }

    public double Salary
    {
        get { return this.salary; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary should be 0 or positive! ");
            }
            this.salary = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Job Title: {JobTitle} ");
        sb.AppendLine($"Company: {Company} ");
        sb.AppendLine($"Salary: {Salary:f2} BGN ");

        return sb.ToString().TrimEnd();
    }

}



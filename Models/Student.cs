namespace StudentManagement.Models;

public class Student{
    public int Id{
        get;
        set;
    }

    public string FirstName{
        get;
        set;
    } = string.Empty;

    public string LastName{
        get;
        set;
    } = string.Empty;

    public string Email{
        get;
        set;
    } = string.Empty;

    public string Phone{
        get;
        set;
    }  = string.Empty;

    public string Gender{
        get;
        set;
    }  = string.Empty;

    public DateTime DOB{
        get;
        set;
    }

    public string Course{
        get;
        set;
    } = string.Empty;

    public int Year{
        get;
        set;
    }

    public string Address{
        get;
        set;
    
    } = string.Empty;

    public bool Status{
        get;
        set;
    }

    public DateTime CreatedAt { 
        get; 
        set;
     }

    public DateTime UpdatedAt { get; set; }




}
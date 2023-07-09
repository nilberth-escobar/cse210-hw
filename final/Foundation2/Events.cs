using System;

// Base Event class
class Event
{
    private string _title;
    private string _description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this._title = title;
        this._description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString()}\nAddress: {address.GetFormattedAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {date.ToShortDateString()}";
    }
}
namespace MadLibs.Models
{
  public class MadLibVariable
  {
    private string _name1;
    private string _name2;
    private string _location;
    private string _exclamation;
    private string _bodypart;
    private string _occupation;
    private string _violentaction;

    public string GetName1()
    {
      return _name1;
    }
    public void SetName1(string newName1)
    {
      _name1 = newName1;
    }

    public string GetName2()
    {
      return _name2;
    }
    public void SetName2(string newName2)
    {
      _name2 = newName2;
    }

    public string GetLocation()
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }

    public string GetExclamation()
    {
      return _exclamation;
    }
    public void SetExclamation(string newExclamation)
    {
      _exclmation = newExclamation;
    }

    public string GetBodyPart()
    {
      return _bodypart;
    }
    public void SetBodyPart(string newBodyPart)
    {
      _bodypart = newBodyPart;
    }

    public string GetOccupation()
    {
      return _occupation;
    }
    public void SetOccupation(string newOccupation)
    {
      _occupation = newOccupation;
    }

    public string GetViolentAction()
    {
      return _violentaction;
    }
    public void SetViolentAction(string newViolentAction)
    {
      _violentaction = newViolentAction;
    }
  }
}

using System.Collections.Generic;


namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }


    public string Name { get; set; }
    public string Ticket { get; set; }
    public string Date { get; set; }
    public bool Completed { get; set; }
    public int MachineId { get; set; }
    public virtual ICollection<EngineerMachine> { get; }
  }
}
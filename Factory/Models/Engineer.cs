using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Factory
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public string Name { get; set; }
    public int EngineerId { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}
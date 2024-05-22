using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask
{
    public class GroupList
    {
        public List<Group> Groups { get; }

        public void AddNewGroup(Group group)
        {
            Group? finded = Groups.FirstOrDefault(g => g.Name == group.Name);

            if (finded is null) Groups.Add(group);
            else Console.WriteLine("This group is exist");
        }
    }
}

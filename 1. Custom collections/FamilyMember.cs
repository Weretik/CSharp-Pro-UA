using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Custom_collections
{
    public class FamilyMember
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public List<FamilyMember> Children { get; set; } = new List<FamilyMember>();

        public FamilyMember(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        public void AddChild(FamilyMember child)
        {
            Children.Add(child);
        }

        public void RemoveChild(FamilyMember child)
        {
            Children.Remove(child);
        }

        public IEnumerable<FamilyMember> GetDescendants()
        {
            foreach (var child in Children)
            {
                yield return child;
                foreach (var descendant in child.GetDescendants())
                {
                    yield return descendant;
                }
            }
        }

        public IEnumerable<FamilyMember> GetChildrenByBirthYear(int year)
        {
            return Children.Where(c => c.BirthYear == year);
        }
    }

    public class FamilyTree
    {
        public FamilyMember Root { get; set; }

        public FamilyTree(FamilyMember root)
        {
            Root = root;
        }

        public void AddFamilyMember(FamilyMember familyMember, FamilyMember parent)
        {
            parent.AddChild(familyMember);
        }

        public void RemoveFamilyMember(FamilyMember familyMember, FamilyMember parent)
        {
            parent.RemoveChild(familyMember);
        }

        public IEnumerable<FamilyMember> GetDescendants(FamilyMember member)
        {
            return member.GetDescendants();
        }

        public IEnumerable<FamilyMember> GetChildrenByBirthYear(FamilyMember member, int year)
        {
            return member.GetChildrenByBirthYear(year);
        }
    }
}

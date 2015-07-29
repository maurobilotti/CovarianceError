using MyApplication.ClassLibrary;

namespace MyApplication.Model
{
    public class ConcreteEntityA : IConcretable
    {
        //some properties i.e:
        public int Id { get; set; }
    }

    public class EntityA : BaseEntity<ConcreteEntityA>
    {

    }
}

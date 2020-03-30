namespace RolePlayV10
{
    public class Warrior
    {
        private string _name;
        private int _level;
        private int _levelup;

        public Warrior(string name)
        {
            _name = name;
            _level = 1;
            _levelup = _level + 1;
        }

        public string Name
        {
            get { return _name; }
        }

        public int level
        {
            get { return _level; }
        }

        public int levelup
        {
            get { return _levelup; }
        }
    }
}
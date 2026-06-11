namespace MDyn
{
    struct Mdyn
    {
        enum Value_Type
        {
            Int,
            Doublev,
            Bool,
            Object,
        }

        Value_Type Vtype;
        int? Int;
        double? Doublev;
        bool? Bool;
        object? Object;
        Dictionary<string, System.Reflection.PropertyInfo>? Members;

        public static Mdyn New<T>(T value)
        {
            Mdyn mdyn = new();
            if (value is int)
            {
                mdyn.Int = value as int?;
                mdyn.Vtype = Value_Type.Int;
                Console.WriteLine("Int");
            }else if (value is double)
            {
                mdyn.Doublev = value as double?;
                mdyn.Vtype = Value_Type.Doublev;
                Console.WriteLine("Doublev");
            }else if (value is bool)
            {
                mdyn.Bool = value as bool?;
                mdyn.Vtype = Value_Type.Bool;
                Console.WriteLine("Bool");
            }else if (value is not decimal and not float and not null && value is not byte)
            {
                mdyn.Object = value;
                mdyn.Vtype = Value_Type.Object;
                Console.WriteLine("Object");

                //foreach (var item in value.GetType().GetProperties())
                //    item.SetValue(value, 20);
                
                foreach (var item in value.GetType().GetProperties()) {
                    mdyn.Members?.Add(item.Name, item);
                }
            }

            return mdyn;
        }

        
    }
}
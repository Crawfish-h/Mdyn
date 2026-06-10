namespace MDyn
{
    struct MDyn
    {
        int? Int;
        double? Doublev;
        bool? Bool;
        object? Object;
        List<int>? List_Int;
        List<double>? List;
        List<bool>? List;
        List<int>? List;

        public static MDyn New<T>(T value)
        {
            if (value is int) 

            return new();
        }
    }
}
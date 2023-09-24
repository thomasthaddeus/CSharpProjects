using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution;

public class Pupil
{
    public string Title { get; private set; }
    public string Origin { get; private set; }

    public Pupil(string title, string origin)
    {
        Title = title;
        Origin = origin;
    }

    public Storm CastWindStorm()
    {
        return new Storm("wind", false, Title);
    }
}
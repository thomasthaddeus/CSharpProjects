using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution;

public class Mage : Pupil
{
    public Mage(string title, string origin) : base(title, origin) { }

    public virtual Storm CastRainStorm()
    {
        return new Storm("rain", false, Title);
    }
}
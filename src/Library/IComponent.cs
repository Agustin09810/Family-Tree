using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IComponent
    {
        void Aceptar(IVisitor Visitor);
    }
}
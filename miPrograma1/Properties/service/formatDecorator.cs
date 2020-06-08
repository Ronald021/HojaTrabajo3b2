
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using miPrograma1.Properties.service;

public abstract class formatDecorator : format
{
    protected format fDecorator;

    public formatDecorator()
    {
    }
    public formatDecorator(format fDecorator)
    {
        this.fDecorator = fDecorator;
    }
    
    public void setDecorator(format fDecorator)
    {
        this.fDecorator = fDecorator;
    }


    public override void create(string[] archivo)
    {
        fDecorator.create(archivo);
    }
}
using System;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab4.Services.Commands;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.CommandExecutor;

public class TreeGotoExecutor : BaseExecutor
{
    public TreeGotoExecutor(CommandFacade facade)
        : base(facade)
    {
    }

    public override void ExecuteCommand(Collection<string> parameters, Collection<string> flags)
    {
        if (parameters == null)
        {
            throw new ArgumentNullException(nameof(parameters));
        }

        Facade.TreeGoto(parameters[0]);
    }
}
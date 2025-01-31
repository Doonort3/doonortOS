﻿
using DoonortOS.Types;

namespace DoonortOS.Core
{
    public class CLI_PWD : CLICommand
    {
        public CLI_PWD()
        {
            names = new string[1]
            {
                "pwd"
            };
            completed = false;
        }

        public override void Execute(string[] args)
        {
            CLI.Pwd();

            base.Execute(args);
        }
    }
}
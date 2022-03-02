using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;

namespace Counter
{
    public class CounterPlugin : IPlugin
    {
        public static string _Id => "counter";
        public string Id => _Id;
        public static int i = 0;
        public PluginOutput Execute(PluginInput input)
        {
            //var lastCount1 = input.Message;
            //if (input.Message == "")
            //{
            //    input.Callbacks.StartSession();
            //    return new PluginOutput("massage", input.PersistentData);
            //}
            //var lastCount = int.Parse(input.PersistentData);
            //var result = (lastCount + 1).ToString();
            //return new PluginOutput(result, result);
            return new PluginOutput((++i).ToString());
        }
    }
}

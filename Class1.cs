using System;
using System.Linq;
using System.Management.Automation;

// Module
namespace powershell
{
  [Cmdlet(VerbsCommon.Get, "Sample")]
  [OutputType(typeof((string, bool, int)))]
  public class GetSampleCmdlet : Cmdlet
  {
    #region Parameters

    [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true)]
    public int NumberOfTimes { get; set; }

    #endregion

    protected override void ProcessRecord()
    {
      base.ProcessRecord();
      WriteObject((string.Join(" ", Enumerable.Repeat("Hello", NumberOfTimes)), true, NumberOfTimes));
    }
  }
}


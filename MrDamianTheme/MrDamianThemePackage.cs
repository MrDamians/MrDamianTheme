using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;
namespace MrDamianTheme
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(MrDamianThemePackage.PackageGuidString)]
    public sealed class MrDamianThemePackage : AsyncPackage
    {
        public const string PackageGuidString = "521df2c8-0562-43bf-95d4-8532c1c531fe";
        #region Package Members
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }
        #endregion
    }
}

using CommunityToolkit.Mvvm.Input;
using Shares.Models;

namespace Shares.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}
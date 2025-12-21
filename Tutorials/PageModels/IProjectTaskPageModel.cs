using CommunityToolkit.Mvvm.Input;
using Tutorials.Models;

namespace Tutorials.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}
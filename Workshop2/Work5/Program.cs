
using Work5;

/* Günlük görevlerimizi içeren ve bu görevlerin tamamlanma bilgisini tutan bir List oluşturunuz.List içinde bulunan görevleri güncelleyen,
tamamlanan görevleri ise silen algoritmayı yazınız. */

MyTask task = new MyTask();
task.Id = 4;
task.Title = "going music course";
task.Completed = false;


TaskManager taskManager = new TaskManager();

taskManager.AddTask(task);
taskManager.GetAllTask();

taskManager.CompleteTask(1);
taskManager.GetAllTask();

taskManager.Deletetask(4);
taskManager.GetAllTask();

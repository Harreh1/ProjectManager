export class TaskDetail {

    TaskId: number;
    TaskTitle: string;
    TaskDescription: string;
    Category: CategoryNames;
}

enum CategoryNames {
    ToDo,
    InProgress,
    Finished
}

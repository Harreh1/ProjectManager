export class TaskDetail {

    TaskId: number;
    TaskTitle: string;
    TaskDescription: string;
    Category: CategoryNames;
    DueDate: Date;
}

enum CategoryNames {
    ToDo,
    InProgress,
    Finished
}

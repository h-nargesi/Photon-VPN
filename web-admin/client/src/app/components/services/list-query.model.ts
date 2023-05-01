export interface ListQuery {
    Start: number,
    Limit: number,
    Search: string | null,
    Filters: { [column: string]: Filter } | null,
    Ordering: { [column: string]: boolean } | null,
    Columns: string[] | null,
}

export interface Filter {
    Type: string | null,
    Value: string | null,
}

export interface Result {
    status: ResultStatus,
    message: string | null,
    data: any | null,
}

export enum ResultStatus {
    Success = 200, Invalid = 400, Error = 500
}

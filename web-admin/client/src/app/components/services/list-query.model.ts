export interface ListQuery {
    Start: number | null,
    Limit: number | null,
    Search: string | null,
    Filters: Filter[] | null,
    Ordering: { [column: string]: boolean } | null,
    Columns: { [column: string]: boolean } | null,
}

export interface Filter {
    Name: string,
    Value: string,
}

export interface Result {
    status: ResultStatus,
    message: string | null,
    data: any | null,
}

export enum ResultStatus {
    Success = 200, Invalid = 400, Error = 500
}

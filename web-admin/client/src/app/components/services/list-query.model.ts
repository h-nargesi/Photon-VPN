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

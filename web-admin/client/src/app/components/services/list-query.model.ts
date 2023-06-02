export interface ListQuery {
  start?: number,
  limit?: number,
  search?: string | null,
  filters?: { [column: string]: Filter } | null,
  ordering?: { [column: string]: boolean } | null,
  columns?: string[] | null,
}

export interface Filter {
  type: string | null,
  value: string | null,
}

export interface Result {
  status: ResultStatus,
  message: string | null,
  data: any | null,
}

export enum ResultStatus {
  Success = 200, Info = 300, Invalid = 400, Error = 500
}

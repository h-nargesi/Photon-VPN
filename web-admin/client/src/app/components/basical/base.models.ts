export type EntitySchema = {
  [name: string]: {
    title: string;
    show: boolean;
    type: ShowType
  }
}

export type SelectOptions = {
  title: string;
  id: number;
}

export enum UIColors {
    secondary = 0,
    primary = 1,
    success = 2,
    danger = 3,
    warning = 4,
    info = 5,
    light = 6,
    dark = 7,
  }

export enum ShowType {
  datetime = "datetime",
  date = "date",
  time = "time",
  duration = "duration",
}

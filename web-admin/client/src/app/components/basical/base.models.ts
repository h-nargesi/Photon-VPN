export type EntitySchema = { [name: string]: { title: string; show: boolean; } }
export type SelectOptions = { title: string; id: number; }
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
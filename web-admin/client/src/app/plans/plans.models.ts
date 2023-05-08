import { UIColors } from '../components';

export interface Plan {
  id: number,
  active: boolean,
  title: string,
  price: number,
  imageFile: string | null,
  description: string | null,
  color: UIColors,
  profiles: Profile[],
  checks: { [attribute: string]: PlanAttribute },
  replies: { [attribute: string]: PlanAttribute },
  created: Date,
  modified: Date,
}

export interface PlanModel {
  id: number,
  title: string,
  active: boolean,
  price: number,
  imageFile: string | null,
  color: UIColors,
  speed: string,
  traffic: string,
  created: Date,
  modified: Date,
}

export interface Profile {
  id: number,
  name: string,
  cloudId: number | null,
  created: Date,
  modified: Date,
}

export interface PlanAttribute {
  id: number,
  groupname: string,
  attribute: string,
  op: string,
  value: string,
  comment: string,
  created: Date,
  modified: Date,
}

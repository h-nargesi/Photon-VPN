import { UIColors } from '../../components';

export interface PermanentUserLog {
  id: number;
  permanentUserId: number;
  witer: number;
  title: string | null;
  color: UIColors;
  content: string;
  created: Date;
  modified: Date;
}

export class ListViewComponent {
  private data_source: any[] | null = null;
  private data_columns: string[] = [];

  get DataSource(): any[] {
    return this.data_source != null ? this.data_source : [];
  }

  get DataColumns(): string[] {
    return this.data_columns;
  }

  get DisplayColumns(): string[] {
    return this.data_columns.slice();
  }

  InitDataSource(data: any[]) {
    this.data_source = data;
    this.data_columns = [];
    if (this.data_source != null && this.data_source.length > 0) {
      for (const c in this.data_source[0])
        this.data_columns.push(c);
    }
  }
}

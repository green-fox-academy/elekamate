import Punchable from './Punchable';

export default abstract class BaseHero {

  private name: string;

  constructor(name: string) {
    this.name = name;
  }

  public abstract punch(other: Punchable): void

  public abstract getMotivationLevel(): number
  
  public abstract toString(): string

  public getName(): string {
    return this.name;
  }
}

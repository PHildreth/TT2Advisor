import React, { Component } from 'react';
import { Skill } from './skill';
import './skillTree.css';

export class SkillTree extends Component {

    skillTree: any;

    constructor(props) {
        super(props);
        this.state = { skillTree: this.props.skillTree, loading: true };
    }

    componentDidMount() {

    }

    render() {
        console.log(this.state.skillTree);
        return (
            <div>
                <h2>Skill Tree</h2>
                <table>
                    <tbody>
                        <tr>
                            <td>
                                <table className='table table-striped' aria-labelledby="tabelLabel">
                                    <thead>
                                        <tr>
                                            <th>Knight Tree</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td />
                                                            <td><Skill  class='knightTree' skill={this.state.skillTree.knightsValor} /></td>
                                                            <td />
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.chivalricOrder} /></td>
                                                            <td><Skill skill={this.state.skillTree.angelicRadiance} /></td>
                                                            <td><Skill skill={this.state.skillTree.midasUltimate} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.cleavingStrike} /></td>
                                                            <td><Skill skill={this.state.skillTree.rejuvenation} /></td>
                                                            <td><Skill skill={this.state.skillTree.willOfMidas} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.barbaricFury} /></td>
                                                            <td><Skill skill={this.state.skillTree.divineWrath} /></td>
                                                            <td><Skill skill={this.state.skillTree.fairyCharm} /></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td>
                                <table className='table table-striped' aria-labelledby="tabelLabel">
                                    <thead>
                                        <tr>
                                            <th>Summoner Tree</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td />
                                                            <td><Skill class='knightTree' skill={this.state.skillTree.petEvolution} /></td>
                                                            <td />
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.summonInferno} /></td>
                                                            <td><Skill skill={this.state.skillTree.heartofMidas} /></td>
                                                            <td><Skill skill={this.state.skillTree.companionWarfare} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.emberArts} /></td>
                                                            <td><Skill skill={this.state.skillTree.lightningBurst} /></td>
                                                            <td><Skill skill={this.state.skillTree.summoningCircle} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.volcanicEruption} /></td>
                                                            <td><Skill skill={this.state.skillTree.flashZip} /></td>
                                                            <td><Skill skill={this.state.skillTree.burningPassion} /></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td>
                                <table className='table table-striped' aria-labelledby="tabelLabel">
                                    <thead>
                                        <tr>
                                            <th>Warlord Tree</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td />
                                                            <td><Skill skill={this.state.skillTree.masterCommander} /></td>
                                                            <td />
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.spoilsofWar} /></td>
                                                            <td><Skill skill={this.state.skillTree.heroicMight} /></td>
                                                            <td><Skill skill={this.state.skillTree.aerialAssault} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.tacticalInsight} /></td>
                                                            <td><Skill skill={this.state.skillTree.searingLight} /></td>
                                                            <td><Skill skill={this.state.skillTree.coordinatedOffensive} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.astralAwakening} /></td>
                                                            <td><Skill skill={this.state.skillTree.commandSupremacy} /></td>
                                                            <td><Skill skill={this.state.skillTree.anchoringShot} /></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table className='table table-striped' aria-labelledby="tabelLabel">
                                    <thead>
                                        <tr>
                                            <th>Sorcerer Tree</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td />
                                                            <td><Skill skill={this.state.skillTree.phantomVengeance} /></td>
                                                            <td />
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.limitBreak} /></td>
                                                            <td><Skill skill={this.state.skillTree.eternalDarkness} /></td>
                                                            <td><Skill skill={this.state.skillTree.manaSiphon} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.manniMana} /></td>
                                                            <td><Skill skill={this.state.skillTree.dimensionalShift} /></td>
                                                            <td><Skill skill={this.state.skillTree.lightningStrike} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.forbiddenContract} /></td>
                                                            <td />
                                                            <td />
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td>
                                <table className='table table-striped' aria-labelledby="tabelLabel">
                                    <thead>
                                        <tr>
                                            <th>Rogue Tree</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td />
                                                            <td><Skill skill={this.state.skillTree.masterThief} /></td>
                                                            <td />
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.ambush} /></td>
                                                            <td><Skill skill={this.state.skillTree.assassinate} /></td>
                                                            <td><Skill skill={this.state.skillTree.summonDagger} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td><Skill skill={this.state.skillTree.strokeOfLuck} /></td>
                                                            <td><Skill skill={this.state.skillTree.daggerStorm} /></td>
                                                            <td><Skill skill={this.state.skillTree.cloaking} /></td>
                                                        </tr>
                                                        <tr>
                                                            <td />
                                                            <td><Skill skill={this.state.skillTree.poisonEdge} /></td>
                                                            <td><Skill skill={this.state.skillTree.deadlyFocus} /></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}

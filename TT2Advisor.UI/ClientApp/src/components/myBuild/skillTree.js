import React, { Component } from 'react';
import { Skill } from './skill';

export class SkillTree extends Component {

    skillTree: any;

    constructor(props) {
        super(props);
        this.state = { skillTree: this.props.skillTree, loading: true };
    }

    componentDidMount() {

    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : SkillTree.renderSkillTree(this.state.skillTree);

        return (
            <div>
                <h2>Skill Tree</h2>
                <table>
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
                                                <tr>
                                                    <td />
                                                    <td><Skill skill={this.state.skillTree.knightsValor}/></td>
                                                    <td />
                                                </tr>
                                                <tr>
                                                    <td>Chivalric Order</td>
                                                    <td>Pet Evolution</td>
                                                    <td>Heart of Midas</td>
                                                </tr>
                                                <tr>
                                                    <td>Cleaving Strike</td>
                                                    <td>Summon Inferno</td>
                                                    <td>Lightning Burst</td>
                                                </tr>
                                                <tr>
                                                    <td>Barbaric Fury</td>
                                                    <td>Volcanic Supremacy</td>
                                                    <td>Flash Zip</td>
                                                </tr>
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
                                                <tr>
                                                    <td />
                                                    <td>Master Commander</td>
                                                    <td />
                                                </tr>
                                                <tr>
                                                    <td>Spoils of War</td>
                                                    <td>Heroic Might</td>
                                                    <td>Aerial Assault</td>
                                                </tr>
                                                <tr>
                                                    <td>Tactical Insight</td>
                                                    <td>Searing Light</td>
                                                    <td>Coordinated Offensive</td>
                                                </tr>
                                                <tr>
                                                    <td>Astral Awakening</td>
                                                    <td>Command Supremacy</td>
                                                    <td>Anchoring Shot</td>
                                                </tr>
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
                                                <tr>
                                                    <td />
                                                    <td>Limit Break</td>
                                                    <td />
                                                </tr>
                                                <tr>
                                                    <td>Midas Ultimate</td>
                                                    <td>Angelic Radiance</td>
                                                    <td>Phantom Vengeance</td>
                                                </tr>
                                                <tr>
                                                    <td>Fairy Charm</td>
                                                    <td>Mana Siphon</td>
                                                    <td>Eternal Darkness</td>
                                                </tr>
                                                <tr>
                                                    <td>Manni Mana</td>
                                                    <td>Lightning Strike</td>
                                                    <td>Dimensional Shift</td>
                                                </tr>
                                                <tr>
                                                    <td />
                                                    <td>Divine Supremacy</td>
                                                    <td>Phantom Supremacy</td>
                                                </tr>
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
                                                <tr>
                                                    <td />
                                                    <td>Master Thief</td>
                                                    <td />
                                                </tr>
                                                <tr>
                                                    <td>Ambush</td>
                                                    <td>Assassinate</td>
                                                    <td>Summon Dagger</td>
                                                </tr>
                                                <tr>
                                                    <td>Stroke Of Luck</td>
                                                    <td>Dagger Storm</td>
                                                    <td>Cloaking</td>
                                                </tr>
                                                <tr>
                                                    <td>Forbidden Contract</td>
                                                    <td>Poison Edge</td>
                                                    <td>Deadly Focus</td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                    </tr>
                </table>
            </div>
        );
    }
}

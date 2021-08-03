import React, { Component } from 'react';

export class PlayerStats extends Component {

    playerStats: any;

    constructor(props) {
        super(props);
        this.state = { playerStats: this.props.playerStats, loading: true };
    }

    componentDidMount() {
        
    }

    render() {
        console.log(this.state.playerStats);
        return (
            <div>
                <h2>Player Stats</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Stat</th>
                            <th>Value</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Max Prestige Stage</td>
                            <td>{this.state.playerStats.maxPrestigeStage}</td>
                        </tr>
                        <tr>
                            <td>Artifacts Collected</td>
                            <td>{this.state.playerStats.artifactsCollected}</td>
                        </tr>
                        <tr>
                            <td>Crafting Power</td>
                            <td>{this.state.playerStats.craftingPower}</td>
                        </tr>
                        <tr>
                            <td>Total Pet Levels</td>
                            <td>{this.state.playerStats.totalPetLevels}</td>
                        </tr>
                        <tr>
                            <td>Skill Points Owned</td>
                            <td>{this.state.playerStats.skillPointsOwned}</td>
                        </tr>
                        <tr>
                            <td>Hero Weapon Upgrades</td>
                            <td>{this.state.playerStats.heroWeaponUpgrades}</td>
                        </tr>
                        <tr>
                            <td>Hero Scroll Upgrades</td>
                            <td>{this.state.playerStats.heroScrollUpgrades}</td>
                        </tr>
                        <tr>
                            <td>Tournaments Joined</td>
                            <td>{this.state.playerStats.tournamentsJoined}</td>
                        </tr>
                        <tr>
                            <td>Undisputed Wins</td>
                            <td>{this.state.playerStats.undisputedWins}</td>
                        </tr>
                        <tr>
                            <td>Tournament Points</td>
                            <td>{this.state.playerStats.tournamentPoints}</td>
                        </tr>
                        <tr>
                            <td>Lifetime Relics</td>
                            <td>{this.state.playerStats.lifetimeRelics}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}

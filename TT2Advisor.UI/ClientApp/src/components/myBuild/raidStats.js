import React, { Component } from 'react';

export class RaidStats extends Component {

    raidStats: any;

    constructor(props) {
        super(props);
        this.state = { raidStats: this.props.raidStats, loading: true };
    }

    componentDidMount() {

    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : RaidStats.renderRaidStats(this.state.raidStats);

        return (
            <div>
                <h2>Raid Stats</h2>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Stat</th>
                            <th>Value</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Raid Level</td>
                            <td>{this.state.raidStats.raidLevel}</td>
                        </tr>
                        <tr>
                            <td>Raid Damage</td>
                            <td>{this.state.raidStats.raidDamage}</td>
                        </tr>
                        <tr>
                            <td>Total Raid Experience</td>
                            <td>{this.state.raidStats.totalRaidExperience}</td>
                        </tr>
                        <tr>
                            <td>Total Raid Attacks</td>
                            <td>{this.state.raidStats.totalRaidAttacks}</td>
                        </tr>
                        <tr>
                            <td>Total Raid Card Levels</td>
                            <td>{this.state.raidStats.totalRaidCardLevels}</td>
                        </tr>
                        <tr>
                            <td>Raid Cards Owned</td>
                            <td>{this.state.raidStats.raidCardsOwned}</td>
                        </tr>
                        <tr>
                            <td>Lifetime Clan Morale</td>
                            <td>{this.state.raidStats.lifetimeClanMorale}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}

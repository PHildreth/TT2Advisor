import React, { Component } from 'react';

export class PlayerStats extends Component<PlayerStatsProps> {

    constructor(props) {
        super(props);
        this.state = { playerStats: this.props.playerStats, loading: true };
    }

    componentDidMount() {
        this.populateMyBuild();
    }

    static renderPlayerStats(playerStats) {
        return (
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : PlayerStats.renderPlayerStats(this.state.playerStats);

        return (
            <div>
                <h2 id="tabelLabel" >Player Stats</h2>
                {contents}
            </div>
        );
    }
}
